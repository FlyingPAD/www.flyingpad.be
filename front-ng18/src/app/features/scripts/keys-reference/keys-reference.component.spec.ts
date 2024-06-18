import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KeysReferenceComponent } from './keys-reference.component';

describe('KeysReferenceComponent', () => {
  let component: KeysReferenceComponent;
  let fixture: ComponentFixture<KeysReferenceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [KeysReferenceComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KeysReferenceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
