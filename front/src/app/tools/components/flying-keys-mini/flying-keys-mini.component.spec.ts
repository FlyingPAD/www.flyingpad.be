import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlyingKeysMiniComponent } from './flying-keys-mini.component';

describe('FlyingKeysMiniComponent', () => {
  let component: FlyingKeysMiniComponent;
  let fixture: ComponentFixture<FlyingKeysMiniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FlyingKeysMiniComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FlyingKeysMiniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
