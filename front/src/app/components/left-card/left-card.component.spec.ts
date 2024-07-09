import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeftCardComponent } from './left-card.component';

describe('LeftCardComponent', () => {
  let component: LeftCardComponent;
  let fixture: ComponentFixture<LeftCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LeftCardComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LeftCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
